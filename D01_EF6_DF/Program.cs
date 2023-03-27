// Todo JS: inserir um empregado com os vossos dados, num dos novos Territories.
// Data Base First

using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D01_EF6_DF
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            #region Declarar o contexto de bd

            var db = new NorthwindEntities();  // Aceder: connectionstring + dbsets

            #endregion

            #region Usar o contexto de bd
            using (db)
            {

                #region Nova Region (1)
                
                Region region01 = new Region();
                Region region02 = new Region();
                Region region03 = new Region();

                region01.RegionID = 5;    // não é identity
                region01.RegionDescription = "Norte";

                region02.RegionID = 6;    // não é identity
                region02.RegionDescription = "Centro";

                region03.RegionID = 7;    // não é identity
                region03.RegionDescription = "Sul";

                db.Region.Add(region01);  // Adicionar o novo registo á tabela em memória (dbset)
                db.Region.Add(region02);  
                db.Region.Add(region03);  

                int countRegions = db.SaveChanges();   // Gravar o registo anterior a bd

                Utility.WriteTitle("Region");

                Utility.WriteMessage($"{countRegions} novas regiões gravadas.", "", "\n\n");

                // Listar, com Linq, as regioes (id - description)

                var queryRegion = db.Region.Select(r => r).OrderBy(r => r.RegionID);

                foreach (var item in queryRegion)
                {
                    Utility.WriteMessage($"{item.RegionID} - {item.RegionDescription}", "", "\n");
                }
                #endregion

                #region Novo Territory da Region (n)

                Territories territories01 = new Territories();
                Territories territories02 = new Territories();
                Territories territories03 = new Territories();

                territories01.TerritoryID = "00001";
                territories01.TerritoryDescription = "Espinho";
                territories01.RegionID = 5;

                territories02.TerritoryID = "00002";
                territories02.TerritoryDescription = "Leiria";
                territories02.RegionID = 6;

                territories03.TerritoryID = "00003";
                territories03.TerritoryDescription = "Beja";
                territories03.RegionID = 7;

                db.Territories.Add(territories01);
                db.Territories.Add(territories02);
                db.Territories.Add(territories03);

                int countTerritories = db.SaveChanges();
                Utility.BlockSeparator("\n\n\n");
                Utility.WriteTitle("Territory");

                Utility.WriteMessage($"{countTerritories} novos territorios gravadas.", "", "\n\n");

                // Listar, com Linq, as regioes (id - description)

                var queryTerritory = db.Territories.Select(t => t).OrderBy(t => t.TerritoryID);

                /*
                foreach (var item in queryTerritory)
                {
                    Utility.WriteMessage($"{item.RegionID} - {item.RegionDescription}", "", "\n");
                }
                */

                // Isto é foreach de linq
                queryTerritory.ToList().ForEach(t => Utility.WriteMessage($"{t.TerritoryID} - {t.TerritoryDescription}", "", "\n"));

                #endregion

            }

            #endregion

            Utility.TerminateConsole();
        }
    }
}

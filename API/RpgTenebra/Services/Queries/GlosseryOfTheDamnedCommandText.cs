using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpgTenebra.Services.Queries
{

    //[GodId]
    //[Name]
    //[Description]
    public class GlosseryOfTheDamnedCommandText : IGlosseryOfTheDamnedCommandText
    {
        public string GetGlosseryOfTheDamneds => "Select * from GlosseryOfTheDamned";
        public string GetGlosseryOfTheDamnedById => "Select * from GlosseryOfTheDamned where GodId = @Id";
        public string AddGlosseryOfTheDamned => "Insert into  [Dapper].[dbo].[GlosseryOfTheDamned ] ([Name], [Description]) values (@Name, @Description)";
        public string UpdateGlosseryOfTheDamned => "Update [Dapper].[dbo].[GlosseryOfTheDamned ] set Name = @Name, Description = @Description where GodId = @Id";
        public string RemoveGlosseryOfTheDamned => "Delete from [Dapper].[dbo].[GlosseryOfTheDamned ] where GodId = @Id";
        public string GetGlosseryOfTheDamnedByIdSp => "GetGlosseryOfTheDamnedId";
    }
}

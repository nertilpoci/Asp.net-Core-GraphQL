using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApi.GraphQL.Types
{
    public class OwnerType : ObjectGraphType<Owner>
    {
        public OwnerType()
        {
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Id property from the owner object.");
            Field(x => x.Name).Description("Name property from the owner object.");
            Field(x => x.Address).Description("Address property from the owner object.");
        }
    }
    public class AppQuery : ObjectGraphType
    {
        public AppQuery()
        {
            Field<ListGraphType<OwnerType>>(
               "owners",
               resolve: context => new Owner[] {
               
               new Owner{ Id="1", Name="2", Address="3"},
               new Owner{ Id="1", Name="2", Address="3"},
               new Owner{ Id="1", Name="2", Address="3"},
               new Owner{ Id="1", Name="2", Address="3"}
               }
           );
        }
    }
}

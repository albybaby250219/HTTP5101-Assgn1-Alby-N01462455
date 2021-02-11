using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HTTP5101_Assgn1_Alby_N01462455.Areas.HelpPage.ModelDescriptions
{
    public class EnumTypeModelDescription : ModelDescription
    {
        public EnumTypeModelDescription()
        {
            Values = new Collection<EnumValueDescription>();
        }

        public Collection<EnumValueDescription> Values { get; private set; }
    }
}
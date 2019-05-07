using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using Planned.Data;

namespace Planned.Rules
{
	public partial class WoItemBusinessRules : Planned.Data.BusinessRules
    {
        
        [OverrideWhen("WoItem", "v100", "grid1")]
        public bool View_v100_Overrides_grid1
        {
            get
            {
                return Context.User.IsInRole("Planned");
            }
        }
        
        [RowBuilder("WoItem", RowKind.New)]
        public void BuildNewWoItem()
        {
            UpdateFieldValue("Status", 'N');
            UpdateFieldValue("Priority", 30);
        }
    }
}

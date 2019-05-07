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
	public partial class WoBusinessRules : Planned.Data.BusinessRules
    {
        
        [RowBuilder("Wo", RowKind.New)]
        public void BuildNewWo()
        {
            UpdateFieldValue("Status", 'N');
            UpdateFieldValue("Priority", 30);
            UpdateFieldValue("ReportedThru", "Office");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wema.BIT.modules;

namespace wema.BIT.models
{
    //this class contains the account of a user linked with the transaction table,
    //such that when a debit or cedit occurs, it deducts it from the account.
    public class Account
    {
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public int Credit { get; set; }

        public int AvailableBalance { get; set; }

        public long BVN { get; set; }

        public long AccountNumber { get; set; }

        public string AccountName { get; set; } = string.Empty;
        public long PhoneNumber { get; set; }

        public virtual Users Users { get; set; }
    };
}

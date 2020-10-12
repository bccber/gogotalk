using System;

namespace GoGoTalk.Models
{
    public class User
	{
		public String UserID { get; set; }
		public String Password { get; set; }
		public String NickName { get; set; }
		public String Signature { get; set; }
		public String HeadImageUrl { get; set; }
		public Int64 CreateTime { get; set; }
		public Int32 Status { get; set; }
	}
}

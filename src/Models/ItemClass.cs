namespace PoeHUD.Models
{
	public class ItemClass
	{
		public string ClassName { get; set; }
		public string ClassCategory { get; set; }
		public ItemClass(string className, string classCategory)
		{
			ClassName = className;
			ClassCategory = classCategory;
		}
	}
}

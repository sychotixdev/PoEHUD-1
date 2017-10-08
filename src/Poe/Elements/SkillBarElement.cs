namespace PoeHUD.Poe.Elements
{
    public class SkillBarElement : Element
    {
        public long TotalSkills => ChildCount;
        public SkillElement this[int k]
        {
            get
            {
                return Children[k].AsObject<SkillElement>();
            }
        }
    }
}

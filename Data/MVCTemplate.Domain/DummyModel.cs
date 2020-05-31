namespace MVCTemplate.Domain
{
    using MVCTemplate.Domain.Common.Models;

    public class DummyModel : BaseDeletableModel<int>
    {
        public string Name { get; set; }
    }
}

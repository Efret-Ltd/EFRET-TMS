using DevExpress.Xpo;
namespace EFRET_TMS.axs
{

    public partial class Movement
    {
        public Movement(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

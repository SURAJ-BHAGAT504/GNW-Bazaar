namespace GNW_Bazaar.Core.Interface
{
    public interface IMapper<in Tin, out Tout>
    {
        Tout Map(Tin input);
    }
}

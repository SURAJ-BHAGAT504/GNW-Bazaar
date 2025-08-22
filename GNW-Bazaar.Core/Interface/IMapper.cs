namespace GNW_Bazaar.Core.Interface
{
    internal interface IMapper<in Tin, out Tout>
    {
        Tout Map(Tin input);
    }
}

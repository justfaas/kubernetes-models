using k8s;
using k8s.Models;

public static class MetadataExtensions
{
    public static string GetAnnotationValue( this IMetadata<V1ObjectMeta> obj, string key, string valueDefault )
    {
        if ( obj.Annotations()?.TryGetValue( key, out var value ) == true )
        {
            return ( value );
        }

        return ( valueDefault );
    }

    public static int GetAnnotationValue( this IMetadata<V1ObjectMeta> obj, string key, int valueDefault )
    {
        if ( obj.Annotations()?.TryGetValue( key, out var value ) == true )
        {
            return ( Int32.Parse( value ) );
        }

        return ( valueDefault );
    }

    public static string GetAnnotationValue( this IMetadata<V1ObjectMeta> obj, (string key, string valueDefault) target )
        => GetAnnotationValue( obj, target.key, target.valueDefault );

    public static int GetAnnotationValue( this IMetadata<V1ObjectMeta> obj, (string key, int valueDefault) target )
        => GetAnnotationValue( obj, target.key, target.valueDefault );
}

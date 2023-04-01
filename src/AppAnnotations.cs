namespace Faactory.k8s.Models;

public static class AppAnnotations
{
    public static readonly ( string Key, string Default ) ServiceAccountName = ( "justfaas.com/service-account-name", "default" );
    public static readonly ( string Key, int Default ) ScaleMin = ( "justfaas.com/scale-min", 1 );
    public static readonly ( string Key, int Default ) ScaleMax = ( "justfaas.com/scale-max", 20 );
    public static readonly ( string Key, string Default ) ScaleToZero = ( "justfaas.com/scale-to-zero", "false" );
    public static readonly ( string Key, string Default ) ScaleToZeroCooldown = ( "justfaas.com/scale-to-zero-cooldown", "30m" );
    public static readonly ( string Key, string Default ) ScaleMode = ( "justfaas.com/scale-mode", "rps" );
    public static readonly ( string Key, int Default ) ScaleThreshold = ( "justfaas.com/scale-threshold", 30 );
}

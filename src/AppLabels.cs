namespace Faactory.k8s.Models;

public static class AppLabels
{
    public const string Name = "justfaas.com/name";
    public const string Namespace = "justfaas.com/namespace";
    public const string WorkspaceName = "justfaas.com/workspace-name";
    public const string Component = "app.kubernetes.io/component";
    public const string PartOf = "app.kubernetes.io/part-of";
    public const string ManagedBy = "app.kubernetes.io/managed-by";
}

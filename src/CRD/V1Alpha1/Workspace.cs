using k8s.Models;

namespace Faactory.k8s.Models;

[KubernetesEntity(
      Group = "justfaas.com"
    , ApiVersion = "v1alpha1"
    , Kind = "Workspace"
    , PluralName = "workspaces" )]
public sealed class V1Alpha1Workspace : CustomKubernetesObject<V1Alpha1Workspace.WorkspaceSpec>
{
    public class WorkspaceSpec
    {
        //
    }
}

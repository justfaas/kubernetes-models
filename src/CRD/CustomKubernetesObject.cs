using System.Text.Json.Serialization;
using k8s;
using k8s.Models;

namespace Faactory.k8s.Models;

public abstract class CustomKubernetesObject : KubernetesObject, IKubernetesObject<V1ObjectMeta>
{
    [JsonPropertyOrder( 2 )]
    public V1ObjectMeta Metadata { get; set; } = new V1ObjectMeta();
}

public abstract class CustomKubernetesObject<TSpec> : CustomKubernetesObject, ISpec<TSpec> where TSpec : class, new()
{
    [JsonPropertyOrder( 3 )]
    public TSpec Spec { get; set; } = new TSpec();
}

using k8s.Models;

namespace Faactory.k8s.Models;

[KubernetesEntity( 
      Group = "justfaas.com"
    , ApiVersion = "v1alpha1"
    , Kind = "Function"
    , PluralName = "functions" )]
public sealed class V1Alpha1Function : CustomKubernetesObject<V1Alpha1Function.FunctionSpec>
{
    public sealed class FunctionSpec
    {
        public string? Image { get; set; }
        public int Port { get; set; } = 8080;
        public IList<V1EnvVar> Env { get; set; } = new List<V1EnvVar>();
        public IngressSpec? Ingress { get; set; }
        public IList<string> Secrets { get; set; } = new List<string>();

        public sealed class IngressSpec
        {
            public string? Host { get; set; }
            public string Path { get; set; } = "/(.*)";
            public TlsSpec? Tls { get; set; }

            public bool IsValid()
                => Host != null;

        }

        public sealed class TlsSpec
        {
            public IssuerRefSpec? IssuerRef { get; set; }

            public bool IsValid()
                => IssuerRef != null && IssuerRef.Kind != null && IssuerRef.Name != null;
        }

        public sealed class IssuerRefSpec
        {
            public string? Name { get; set; }
            public string? Kind { get; set; }
        }
    }
}

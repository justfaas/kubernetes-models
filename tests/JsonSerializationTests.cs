using Faactory.k8s.Models;
using k8s.Models;

namespace tests;

public class JsonSerializationTests
{
    [Fact]
    public void TestOrder()
    {
        var app = new V1Alpha1Function
        {
            Spec = new V1Alpha1Function.FunctionSpec
            {
                Image = "image:tag"
            },
            Metadata = new V1ObjectMeta
            {
                Name = "test",
                NamespaceProperty = "default"
            },
            Kind = "Function",
            ApiVersion = "v1alpha1",
        };

        var json = k8s.KubernetesJson.Serialize( app );
        var expectedJson = 
        """
        {"apiVersion":"v1alpha1","kind":"Function","metadata":{"name":"test","namespace":"default"},"spec":{"image":"image:tag","port":8080,"env":[],"secrets":[],"configMaps":[]}}
        """;

        Assert.Equal( expectedJson, json );
    }
}

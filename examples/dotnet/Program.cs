using System.Collections.Generic;
using System.Linq;
using Pulumi;
using Openwrt = Pulumi.Openwrt;

return await Deployment.RunAsync(() => 
{
    var myRandomResource = new Openwrt.Random("myRandomResource", new()
    {
        Length = 24,
    });

    return new Dictionary<string, object?>
    {
        ["output"] = 
        {
            { "value", myRandomResource.Result },
        },
    };
});


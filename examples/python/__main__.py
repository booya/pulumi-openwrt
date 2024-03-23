import pulumi
import pulumi_openwrt as openwrt

my_random_resource = openwrt.Random("myRandomResource", length=24)
pulumi.export("output", {
    "value": my_random_resource.result,
})

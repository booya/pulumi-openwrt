import * as pulumi from "@pulumi/pulumi";
import * as openwrt from "@pulumi/openwrt";

const myRandomResource = new openwrt.Random("myRandomResource", {length: 24});
export const output = {
    value: myRandomResource.result,
};

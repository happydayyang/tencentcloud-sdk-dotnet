/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeNatGatewaysRequest : AbstractModel
    {
        
        /// <summary>
        /// NAT网关统一 ID，形如：`nat-123xx454`。
        /// </summary>
        [JsonProperty("NatGatewayIds")]
        public string[] NatGatewayIds{ get; set; }

        /// <summary>
        /// 过滤条件，参数不支持同时指定NatGatewayIds和Filters。
        /// <li>nat-gateway-id - String - （过滤条件）协议端口模板实例ID，形如：`nat-123xx454`。</li>
        /// <li>vpc-id - String - （过滤条件）私有网络 唯一ID，形如：`vpc-123xx454`。</li>
        /// <li>nat-gateway-name - String - （过滤条件）协议端口模板实例ID，形如：`test_nat`。</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认为20，最大值为100。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "NatGatewayIds.", this.NatGatewayIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

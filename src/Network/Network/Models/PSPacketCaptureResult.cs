﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Network.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using WindowsAzure.Commands.Common.Attributes;

    public class PSPacketCaptureResult : PSChildResource
    {
        [Ps1Xml(Target = ViewControl.Table)]
        public string ProvisioningState { get; set; }

        public string Target { get; set; }

        [JsonProperty(Order = 1)]
        public PSPacketCaptureMachineScope Scope { get; set; }

        [JsonProperty(Order = 1)]
        public PSPacketCaptureTargetType? TargetType { get; set; }

        [Ps1Xml(Target = ViewControl.Table)]
        public int? BytesToCapturePerPacket { get; set; }

        [Ps1Xml(Target = ViewControl.Table)]
        public uint? TotalBytesPerSession { get; set; }

        [Ps1Xml(Target = ViewControl.Table)]
        public int? TimeLimitInSeconds { get; set; }

        [JsonProperty(Order = 1)]
        public PSStorageLocation StorageLocation { get; set; }

        [JsonProperty(Order = 1)]
        public List<PSPacketCaptureFilter> Filters { get; set; }

        [JsonProperty(Order = 2)]
        public bool? ContinuousCapture { get; set; }

        [JsonProperty(Order = 3)]
        public PSPacketCaptureSettings CaptureSettings { get; set; }

        [JsonIgnore]
        public string FiltersText
        {
            get { return JsonConvert.SerializeObject(this.Filters, Formatting.Indented, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore }); }
        }

        [JsonIgnore]
        public string ScopeText
        {
            get { return JsonConvert.SerializeObject(this.Scope, Formatting.Indented, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore }); }
        }

        [JsonIgnore]
        public string StorageLocationText
        {
            get { return JsonConvert.SerializeObject(this.StorageLocation, Formatting.Indented, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore }); }
        }

        [JsonIgnore]
        public string CaptureSettingsText
        {
            get { return JsonConvert.SerializeObject(this.CaptureSettings, Formatting.Indented, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore }); }
        }

        public bool ShouldSerializeStorageLocation()
        {
            return !string.IsNullOrEmpty(this.Name);
        }

        public bool ShouldSerializeFilters()
        {
            return !string.IsNullOrEmpty(this.Name);
        }
    }
}

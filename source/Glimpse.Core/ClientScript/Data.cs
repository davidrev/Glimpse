using System.Collections.Generic;
using Glimpse.Core.Extensibility;
using Glimpse.Core.Resource;

namespace Glimpse.Core.ClientScript
{
    public class Data : IDynamicClientScript, IParameterValueProvider
    {
        public ScriptOrder Order
        {
            get { return ScriptOrder.RequestDataScript; }
        }

        public string GetResourceName()
        {
            return RequestResource.InternalName;
        }

        public void OverrideParameterValues(IDictionary<string, string> defaults)
        {
            defaults[ResourceParameter.Callback.Name] = "glimpse.data.initData";
        }
    }
}
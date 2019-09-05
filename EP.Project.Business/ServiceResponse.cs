using System.Collections.Generic;
using EP.Project.Business.Abstract;
using Newtonsoft.Json;

namespace EP.Project.Business
{
  public class ServiceResponse<T> : ResponseBase
  where T : class,new()
  {
    [JsonProperty]
    public T Entity { get; set; }
    [JsonProperty]
    public List<T> Entities { get; set; }

    public ServiceResponse()
    {
      Errors = new List<string>();
      Entities = new List<T>();
    }
  }
}

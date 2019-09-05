using System;
using System.Collections.Generic;
using System.Text;

namespace EP.Project.Business.Abstract
{
  public abstract class ResponseBase
  {
    public List<string> Errors { get; set; }
    public bool HasError { get; set; }
    public bool IsSuccessful { get; set; }
  }
}

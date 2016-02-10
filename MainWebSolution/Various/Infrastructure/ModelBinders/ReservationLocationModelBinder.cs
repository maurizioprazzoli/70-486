using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Various.Models;

namespace Various.Infrastructure.ModelBinders
{
    public class ReservationLocationModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var raw = bindingContext.ValueProvider.GetValue("loc");
            dynamic data = raw.AttemptedValue.ToString().Split(',');
            return new ReservationLocation { City = data[0], State =  data[1] };
        }
    }
}
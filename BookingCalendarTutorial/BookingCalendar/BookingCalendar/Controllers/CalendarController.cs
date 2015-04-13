using System.Linq;
using System.Web;
using System.Web.Mvc;



using DHTMLX.Scheduler;
using DHTMLX.Common;
using DHTMLX.Scheduler.Data;
using BookingCalendar.Models;
using System.Collections.Generic;


namespace BookingCalendar.Controllers
{
    public class CalendarController : Controller
    {
        public ActionResult Index()
        {
            var scheduler = new DHXScheduler(this);
            scheduler.Skin = DHXScheduler.Skins.Terrace;
            scheduler.Config.multi_day = true;//render multiday events
            scheduler.LoadData = true;
            scheduler.EnableDataprocessor = true;


            return View(scheduler);
        }


        public ContentResult Data()
        {
            var data = new SchedulerAjaxData(
                new RoomBookingDataContext().Events
            );


            return (ContentResult)data;
        }


        public ContentResult Save(int? id, FormCollection actionValues)
        {
            var action = new DataAction(actionValues);
            var data = new RoomBookingDataContext();


            try
            {
                var changedEvent = DHXEventsHelper.Bind<Event>(actionValues);
                switch (action.Type)
                {
                    case DataActionTypes.Insert:
                        data.Events.InsertOnSubmit(changedEvent);
                        break;
                    case DataActionTypes.Delete:
                        changedEvent = data.Events.SingleOrDefault(ev => ev.id == action.SourceId);
                        data.Events.DeleteOnSubmit(changedEvent);
                        break;
                    default:// "update"                          
                        var eventToUpdate = data.Events.SingleOrDefault(ev => ev.id == action.SourceId);
                        DHXEventsHelper.Update(eventToUpdate, changedEvent, new List<string>() { "id" });
                        break;
                }
                data.SubmitChanges();
                action.TargetId = changedEvent.id;
            }
            catch
            {
                action.Type = DataActionTypes.Error;
            }
            return new AjaxSaveResponse(action);
        }
    }
}


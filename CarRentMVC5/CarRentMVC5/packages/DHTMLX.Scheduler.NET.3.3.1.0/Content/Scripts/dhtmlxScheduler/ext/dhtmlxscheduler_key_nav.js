/*
@license
dhtmlxScheduler.Net v.3.3.0 

This software is covered by DHTMLX Evaluation License. Contact sales@dhtmlx.com to get Commercial or Enterprise license. Usage without proper license is prohibited.

(c) Dinamenta, UAB.
*/
Scheduler.plugin(function(e){e._temp_key_scope=function(){function t(e){delete e.rec_type,delete e.rec_pattern,delete e.event_pid,delete e.event_length}e.config.key_nav=!0;var n,a,d=null;e.attachEvent("onMouseMove",function(t,d){n=e.getActionData(d).date,a=e.getActionData(d).section}),e._make_pasted_event=function(d){var i=d.end_date-d.start_date,r=e._lame_copy({},d);if(t(r),r.start_date=new Date(n),r.end_date=new Date(r.start_date.valueOf()+i),a){var _=e._get_section_property();r[_]=e.config.multisection?d[_]:a;

}return r},e._do_paste=function(t,n,a){e.addEvent(n),e.callEvent("onEventPasted",[t,n,a])},e._is_key_nav_active=function(){return this._is_initialized()&&!this._is_lightbox_open()&&this.config.key_nav?!0:!1},dhtmlxEvent(document,_isOpera?"keypress":"keydown",function(t){if(!e._is_key_nav_active())return!0;if(t=t||event,37==t.keyCode||39==t.keyCode){t.cancelBubble=!0;var n=e.date.add(e._date,37==t.keyCode?-1:1,e._mode);return e.setCurrentView(n),!0}var a=e._select_id;if(t.ctrlKey&&67==t.keyCode)return a&&(e._buffer_id=a,
d=!0,e.callEvent("onEventCopied",[e.getEvent(a)])),!0;if(t.ctrlKey&&88==t.keyCode&&a){d=!1,e._buffer_id=a;var i=e.getEvent(a);e.updateEvent(i.id),e.callEvent("onEventCut",[i])}if(t.ctrlKey&&86==t.keyCode){var i=e.getEvent(e._buffer_id);if(i){var r=e._make_pasted_event(i);if(d)r.id=e.uid(),e._do_paste(d,r,i);else{var _=e.callEvent("onBeforeEventChanged",[r,t,!1,i]);_&&(e._do_paste(d,r,i),d=!0)}}return!0}})},e._temp_key_scope()});
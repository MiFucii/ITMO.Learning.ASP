//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RSVPSeminarsWebsite
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reports
    {
        public int ReportId { get; set; }
        public string NameReport { get; set; }
        public string Annotation { get; set; }
        public int GuestResponseId { get; set; }
    
        public virtual WorkshopParticipants WorkshopParticipants { get; set; }
    }
}

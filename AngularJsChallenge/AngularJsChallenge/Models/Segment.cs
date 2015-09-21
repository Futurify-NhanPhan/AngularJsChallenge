using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularJsChallenge.Models
{
    public enum DocumentType{
        Technical=0,
        Financial=1
    }
    public enum State{
        Published=0,
        Draft=1
    }

    public class Segment
    {
        public int Id {get;set;}
        public string Title {get;set;}
        public string Content {get;set;}
        public DocumentType  DocumentType {get;set;}
        public List<string> ContentClassification {get;set;}
        public State State { get; set; }
        public string ThumbnailUrl {get;set;}
        public DateTime LastModifiedOn {get;set;}
        public DateTime CreatedOn {get;set;}

    }
}
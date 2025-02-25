﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XHS.Models.XHS.ApiOutputModel.Common;
using XHS.Models.XHS.ApiOutputModel.UserPosted;

namespace XHS.Models.XHS.ApiOutputModel.NodeDetail
{
    public class NoteCardModel: BaseNoteCardModel
    {
        [JsonProperty("time")]
        public long Time { get; set; }
        [JsonProperty("last_update_time")]
        public long LastUpdateTime { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("desc")]
        public string Desc { get; set; }
        [JsonProperty("image_list")]
        public List<ImageListModel> ImageList { get; set; }
        [JsonProperty("tag_list")]
        public List<TagListModel> TagList { get; set; }
        [JsonProperty("note_id")]
        public string NoteId { get; set; }

        [JsonProperty("video")]
        public Video Video { get; set; }

    }
}

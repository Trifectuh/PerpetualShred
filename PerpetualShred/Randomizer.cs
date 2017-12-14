﻿using PerpetualShred.Models;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace PerpetualShred
{
    public class Randomizer : Controller
    {
        static string previousVid;
        ICookieService _cookieService;

        public Randomizer(ICookieService cookieService)
        {
            _cookieService = cookieService;
        }

        public int RandomVidPicker(List<WebVid> vidList)
        {
            if (vidList.Count > 0)
            {
                int id;
                WebVid vidToPlay;
                List<string> unwatchedIds = null;

                string unwatchedCookie = _cookieService.GetCookie("randomVideoUnwatched");
                if (string.IsNullOrWhiteSpace(unwatchedCookie))
                {
                    string randomVideoUnwatchedValue = string.Join(';', (from v in vidList
                                                                         select v.ID));
                    _cookieService.CreateCookie("randomVideoUnwatched", randomVideoUnwatchedValue);
                }
                else
                {
                    unwatchedIds = unwatchedCookie.Split(';').ToList();
                }

                int selectedVidIndex = Int32.Parse(unwatchedIds[(new Random().Next(0, unwatchedIds.Count))]);
                vidToPlay = vidList[selectedVidIndex-1];
                id = vidToPlay.ID;
                previousVid = JsonConvert.SerializeObject(vidToPlay);

                return id;
            }
            return -1;
        }
    }
}

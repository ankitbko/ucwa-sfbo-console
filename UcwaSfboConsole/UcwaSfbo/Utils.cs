﻿using System;

namespace UcwaSfboConsole.UcwaSfbo
{
    public class Helpers
    {
        public static String ReduceUriToProtoAndHost(string longUri)
        {
            string reduceUriToProtoAndHost = String.Empty;
            reduceUriToProtoAndHost = new Uri(longUri).Scheme + "://" + new Uri(longUri).Host;
            return reduceUriToProtoAndHost;
        }

    }
}

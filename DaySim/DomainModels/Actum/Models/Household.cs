﻿// Copyright 2005-2008 Mark A. Bradley and John L. Bowman
// Copyright 2011-2013 John Bowman, Mark Bradley, and RSG, Inc.
// You may not possess or use this file without a License for its use.
// Unless required by applicable law or agreed to in writing, software
// distributed under a License for its use is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.

using System.Runtime.InteropServices;
using DaySim.DomainModels.Actum.Models.Interfaces;
using DaySim.Framework.Factories;
using DaySim.Framework.Persistence;

namespace DaySim.DomainModels.Actum.Models {
  [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
  [Factory(Factory.PersistenceFactory, Category = Category.Model, DataType = DataType.Actum)]
  public sealed class Household : DomainModels.Default.Models.Household, IActumHousehold {
    //JLB 20160323
    [ColumnName("hmuncode")]
    public int MunicipalCode { get; set; }

    [ColumnName("hdisstat")]
    public double StationDistance { get; set; }

    [ColumnName("hparkpos")]
    public int ParkingAvailability { get; set; }

    [ColumnName("inetpaym")]
    public int InternetPaymentMethod { get; set; }
  }
}

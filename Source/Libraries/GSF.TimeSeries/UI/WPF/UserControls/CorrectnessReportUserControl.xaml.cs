﻿//******************************************************************************************************
//  CorrectnessReportUserControl.xaml.cs - Gbtc
//
//  Copyright © 2015, Grid Protection Alliance.  All Rights Reserved.
//
//  Licensed to the Grid Protection Alliance (GPA) under one or more contributor license agreements. See
//  the NOTICE file distributed with this work for additional information regarding copyright ownership.
//  The GPA licenses this file to you under the MIT License (MIT), the "License"; you may
//  not use this file except in compliance with the License. You may obtain a copy of the License at:
//
//      http://www.opensource.org/licenses/MIT
//
//  Unless agreed to in writing, the subject software distributed under the License is distributed on an
//  "AS-IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. Refer to the
//  License for the specific language governing permissions and limitations.
//
//  Code Modification History:
//  ----------------------------------------------------------------------------------------------------
//  01/08/2015 - Jeff Walker
//       Generated original version of source code.
//  06/08/2015 - J. Ritchie Carroll
//       Refactored to use common UI reporting control.
//
//******************************************************************************************************

using System;
using GSF.TimeSeries.UI.ViewModels;

namespace GSF.TimeSeries.UI.UserControls
{
    /// <summary>
    /// Interaction logic for CorrectnessReportUserControl.xaml
    /// </summary>
    public partial class CorrectnessReportUserControl
    {
        /// <summary>
        /// Creates a new instance of the <see cref="CorrectnessReportUserControl"/> class.
        /// </summary>
        public CorrectnessReportUserControl()
        {
            InitializeComponent();

            ReportUserControl userControl = new ReportUserControl();
            ReportViewModel viewModel = userControl.ViewModel;

            viewModel.ReportType = "Correctness";
            viewModel.ReportGenerationTime = new DateTime(1, 1, 1, 4, 0, 0);
            viewModel.OriginalReportGenerationTime = viewModel.ReportGenerationTime;

            AddChild(userControl);
        }
    }
}

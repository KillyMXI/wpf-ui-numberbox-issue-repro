// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.

namespace NumberBoxIssueRepro1.ViewModels.Pages;

public partial class DashboardViewModel : ObservableObject
{
    [ObservableProperty]
    private double lostFocusValue = 39;

    [ObservableProperty]
    private double propertyChangeValue = 42;


    [ObservableProperty]
    private string lostFocusString = "139";

    [ObservableProperty]
    private string propertyChangeString = "142";


    [ObservableProperty]
    private string lostFocusString2 = "239";

    [ObservableProperty]
    private string propertyChangeString2 = "242";
}

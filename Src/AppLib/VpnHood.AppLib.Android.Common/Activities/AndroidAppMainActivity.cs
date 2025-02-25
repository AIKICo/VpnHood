﻿using VpnHood.Core.Client.Device.Droid.ActivityEvents;

namespace VpnHood.AppLib.Droid.Common.Activities;

public abstract class AndroidAppMainActivity : ActivityEvent
{
    protected AndroidAppMainActivityHandler MainActivityHandler = null!;
    protected abstract AndroidAppMainActivityHandler CreateMainActivityHandler();

    protected override void OnCreate(Bundle? savedInstanceState)
    {
        MainActivityHandler = CreateMainActivityHandler(); // must before base.OnCreate to make sure event is fired
        base.OnCreate(savedInstanceState);
    }
}
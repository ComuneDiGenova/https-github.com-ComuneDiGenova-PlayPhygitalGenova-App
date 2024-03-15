﻿using UnityEngine;
using System.Collections;

public class BrowserOpener : MonoBehaviour {

	public string pageToOpen = "https://www.google.com";

	// check readme file to find out how to change title, colors etc.
	public void OnButtonClicked() {
		InAppBrowser.DisplayOptions options = new InAppBrowser.DisplayOptions();
		options.displayURLAsPageTitle = false;
		options.pageTitle = "InAppBrowser example";

		InAppBrowser.OpenURL(pageToOpen, options);
	}

	public void OnClearCacheClicked() {
		Debug.Log("Clear Cache!");
		InAppBrowser.ClearCache();
	}
}
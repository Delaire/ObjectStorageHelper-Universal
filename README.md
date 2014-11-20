ObjectStorageHelper-Universal
=============================

In this tutorial I am going to show you how to use a class called ObjectStorageHelper which will allow you to save information in a class, this class for example could be called settings and would allow you to store data about the applciation (for example how many times it has been launched)
<<<<<<< HEAD
=======

If you don't want to have to look at the code here is the important part, these two methodes to load and save the Class:

## Method to save Settings
	public static void SaveSettings()
	{
		(new ObjectStorageHelper<ApplicationSettings>(StorageType.Local)).Save(AppSettings, "ApplicationSettings");
	}

## Method to load settings
	private static void LoadSettings()
	{
		AppSettings = (new ObjectStorageHelper<ApplicationSettings>(StorageType.Local)).Load("ApplicationSettings", new ApplicationSettings());
		if (!AppSettings.IsInitialized)
		{
			AppSettings.InitData();
		}
		//example of settings
		//Incrementing the number of times the app has been loaded
		AppSettings.RunCount++;
	}

>>>>>>> origin/master

If you don't want to have to look at the code here is the important part, these two methodes to load and save the Class:

## Method to save Settings
	public static void SaveSettings()
	{
		(new ObjectStorageHelper<ApplicationSettings>(StorageType.Local)).Save(AppSettings, "ApplicationSettings");
	}

## Mmethod to load settings
	private static void LoadSettings()
	{
		AppSettings = (new ObjectStorageHelper<ApplicationSettings>(StorageType.Local)).Load("ApplicationSettings", new ApplicationSettings());
		if (!AppSettings.IsInitialized)
		{
			AppSettings.InitData();
		}
		//example of settings
		//Incrementing the number of times the app has been loaded
		AppSettings.RunCount++;
	}
	
	
	
## Supported Platforms
* Windows Store
* Windows Phone
* Windows Universal

## Contribute	
Please help out

##License
MIT

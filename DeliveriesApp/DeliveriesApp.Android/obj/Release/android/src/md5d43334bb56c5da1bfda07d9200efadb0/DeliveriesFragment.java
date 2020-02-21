package md5d43334bb56c5da1bfda07d9200efadb0;


public class DeliveriesFragment
	extends android.support.v4.app.ListFragment
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("DeliveriesApp.Droid.DeliveriesFragment, DeliveriesApp.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", DeliveriesFragment.class, __md_methods);
	}


	public DeliveriesFragment () throws java.lang.Throwable
	{
		super ();
		if (getClass () == DeliveriesFragment.class)
			mono.android.TypeManager.Activate ("DeliveriesApp.Droid.DeliveriesFragment, DeliveriesApp.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}

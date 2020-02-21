package md5d43334bb56c5da1bfda07d9200efadb0;


public class DeliveryAdapterViewHolder
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("DeliveriesApp.Droid.DeliveryAdapterViewHolder, DeliveriesApp.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", DeliveryAdapterViewHolder.class, __md_methods);
	}


	public DeliveryAdapterViewHolder () throws java.lang.Throwable
	{
		super ();
		if (getClass () == DeliveryAdapterViewHolder.class)
			mono.android.TypeManager.Activate ("DeliveriesApp.Droid.DeliveryAdapterViewHolder, DeliveriesApp.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

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

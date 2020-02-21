package md56f8564a7b2a31cc679c302238f667292;


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
		mono.android.Runtime.register ("DeliveriesApp.Droid.DeliveryAdapterViewHolder, DeliveriesApp.Android", DeliveryAdapterViewHolder.class, __md_methods);
	}


	public DeliveryAdapterViewHolder ()
	{
		super ();
		if (getClass () == DeliveryAdapterViewHolder.class)
			mono.android.TypeManager.Activate ("DeliveriesApp.Droid.DeliveryAdapterViewHolder, DeliveriesApp.Android", "", this, new java.lang.Object[] {  });
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

package md553785878d05d253885de01ea15152f27;


public class AndroidNewsModel
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("NewsReader.android.AndroidNewsModel, NewsReader.android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", AndroidNewsModel.class, __md_methods);
	}


	public AndroidNewsModel () throws java.lang.Throwable
	{
		super ();
		if (getClass () == AndroidNewsModel.class)
			mono.android.TypeManager.Activate ("NewsReader.android.AndroidNewsModel, NewsReader.android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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

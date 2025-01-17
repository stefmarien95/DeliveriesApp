﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DeliveriesApp.Model;

namespace DeliveriesApp.Droid
{
    class DeliveryAdapter : BaseAdapter
    {
        Context context;
        List<Delivery> deliveries;

        public DeliveryAdapter(Context context, List<Delivery> deliveries)
        {
            this.context = context;
            this.deliveries = deliveries;
        }


        public override Java.Lang.Object GetItem(int position)
        {
            return position;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView;
            DeliveryAdapterViewHolder holder = null;

            if (view != null)
                holder = view.Tag as DeliveryAdapterViewHolder;

            if (holder == null)
            {
                holder = new DeliveryAdapterViewHolder();
                var inflater = context.GetSystemService(Context.LayoutInflaterService).JavaCast<LayoutInflater>();
            
                view = inflater.Inflate(Resource.Layout.DeliveryCell, parent, false);
                holder.Name = view.FindViewById<TextView>(Resource.Id.deliveryNameTextView);
                holder.Status = view.FindViewById<TextView>(Resource.Id.deliveryStatisTextView);
                view.Tag = holder;
            }


            var delivery = deliveries[position];
            holder.Name.Text = delivery.Naam;
            switch(delivery.Status)
            {
                case 0:
                    holder.Status.Text = "waiting for delivery person";
                    break;
                case 1:
                    holder.Status.Text = "out for delivery";
                    break;
                case 2:
                    holder.Status.Text = "delivered";
                    break;
            }

            return view;
        }

       
        public override int Count
        {
            get
            {
                return deliveries.Count;
            }
        }

    }

    class DeliveryAdapterViewHolder : Java.Lang.Object
    {
       
        public TextView Name { get; set; }
        public TextView Status { get; set; }
    }
}
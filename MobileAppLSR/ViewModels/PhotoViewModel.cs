using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;
using MobileAppLSR.Views;
using System.Threading.Tasks;
using System.IO;

namespace MobileAppLSR.ViewModels
{
    internal class PhotoViewModel : BaseViewModel
    {
        public Command TakePhoto { get; set; }
        public Image resultImage { get; set; }

        public PhotoViewModel()
        {
            TakePhoto = new Command(TakePhotoCommand);
        }

        async void TakePhotoCommand()
        {
            var result = await MediaPicker.CapturePhotoAsync();

            if (result != null)
            {
                var stream = await result.OpenReadAsync();
                resultImage.Source = ImageSource.FromStream(() => stream);
            }

            
        }
    }
}
    //    async Task TakePhotoAsync()
    //    {
    //        try
    //        {
    //            var photo = await MediaPicker.CapturePhotoAsync();
    //            await LoadPhotoAsync(photo);
    //            Console.WriteLine($"PhotoOK Chenmin:");
    //    }
    //}
        
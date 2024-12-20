using Amazon.S3.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PasswordManagerv1.Classes.Utils;
using PasswordManagerv1.Resources.Localization;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManagerv1.ViewModels.Services
{
    public partial class S3FilesPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsBucketPickerVisible))]
        public List<S3Bucket> _bucketList;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(S3ObjectVersionsList))]
        public S3Bucket _selectedBucket;

        [ObservableProperty]
        public List<S3ObjectVersion> s3ObjectVersionsList;

        [ObservableProperty]
        public ObservableCollection<S3File> s3Files;

        public S3FilesPageViewModel()
        {
            Console.WriteLine("### S3FilesPageViewModel: ViewModel Instantiated Successfully");
        }

        [RelayCommand]
        public async Task ListBucketsAsync()
        {
            var response = await AWSS3Utils.GetBuckets();
            BucketList = response.Buckets;
        }

        public async void PresentS3Objects()
        {
            var response = await AWSS3Utils.GetObjectListWithAllVersionsAsync(SelectedBucket.BucketName);
            S3Files = new();
            foreach (var obj in response)
            {
                S3Files.Add(new S3File(obj.Key, obj.LastModified.ToString()));
            }
        }

        public bool IsBucketPickerVisible
        {
            get => BucketList?.Count > 0;
        }

        partial void OnSelectedBucketChanged(S3Bucket value)
        {
            PresentS3Objects();
        }
    }

    public partial class S3File : ObservableObject
    {
        [ObservableProperty]
        public string _name;

        [ObservableProperty]
        public string _lastModified;

        public S3File(string name, string lastModified)
        {
            this._name = name;
            this._lastModified = lastModified;
        }
    }
}

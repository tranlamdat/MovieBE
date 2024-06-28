using CloudinaryDotNet;
using CloudinaryDotNet.Actions;

namespace Sever.Services.Cloudinaries
{
    public class CloudinaryService : IClodinaryService
    {
        private readonly Cloudinary _cloudinary;

        public CloudinaryService()
        {
            var account = new Account(
                Environment.GetEnvironmentVariable("CLOUDINARY_NAME"),
                Environment.GetEnvironmentVariable("CLOUDINARY_API_KEY"),
                Environment.GetEnvironmentVariable("CLOUDINARY_API_SECRET")
            );

            _cloudinary = new Cloudinary(account);
        }

        public async Task<ImageUploadResult> UploadImageAsync(IFormFile file, string folderName)
        {
            var uploadResult = new ImageUploadResult();

            if (file.Length > 0)
            {
                using (var stream = file.OpenReadStream())
                {
                    var uploadParams = new ImageUploadParams()
                    {
                        File = new FileDescription(file.FileName, stream),
                        Folder = folderName
                    };

                    uploadResult = await _cloudinary.UploadAsync(uploadParams);
                }
            }

            return uploadResult;
        }

        public async Task<VideoUploadResult> UploadVideoAsync(IFormFile file, string folderName)
        {
            var uploadResult = new VideoUploadResult();

            if (file.Length > 0)
            {
                using (var stream = file.OpenReadStream())
                {
                    var uploadParams = new VideoUploadParams()
                    {
                        File = new FileDescription(file.FileName, stream),
                        Folder = folderName
                    };

                    uploadResult = await _cloudinary.UploadAsync(uploadParams);
                }
            }

            return uploadResult;
        }

        public async Task<DeletionResult> DeleteMediaAsync(string publicId)
        {
            var deleteParams = new DeletionParams(publicId);
            var result = await _cloudinary.DestroyAsync(deleteParams);
            return result;
        }
    }
}

import os
import shutil

# Define file categories
categories = {
    "Images": [".jpg", ".jpeg", ".png", ".gif"],
    "Documents": [".pdf", ".docx", ".txt"],
    "Videos": [".mp4", ".mkv"],
    "Music": [".mp3", ".wav"],
}

# Get the directory path
directory = input("📂 Enter the folder path to organize: ")

for file in os.listdir(directory):
    file_path = os.path.join(directory, file)
    
    if os.path.isfile(file_path):
        for category, extensions in categories.items():
            if file.lower().endswith(tuple(extensions)):
                category_path = os.path.join(directory, category)
                os.makedirs(category_path, exist_ok=True)
                shutil.move(file_path, category_path)
                print(f"✅ Moved {file} to {category}")
                break

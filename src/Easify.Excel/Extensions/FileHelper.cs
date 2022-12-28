// This software is part of the LittleBlocks.Excel Library
// Copyright (C) 2018 LittleBlocks
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
// 
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
// 

using System.IO;

namespace LittleBlocks.Excel.Extensions
{
    public static class FileHelper
    {
        public static MemoryStream ReadFileToMemoryStream(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"File not found in {path}");

            var bytes = File.ReadAllBytes(path);

            var stream = new MemoryStream();
            stream.Write(bytes, 0, bytes.Length);
            stream.Position = 0;

            return stream;
        }
    }
}
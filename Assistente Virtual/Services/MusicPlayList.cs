using System;
using System.Collections.Generic;
using System.Linq;
using Assistente_Virtual.Entities;
using System.Windows.Forms;
using Assis_Serializer;

namespace Musics
{
    
    class MusicPlayList
    {
        DataSerializer serializer = new DataSerializer();        

        public string Name { get; set; }
      
        string savePath;
        public List<Music> musicList = new List<Music>();
        Music music;
        public MusicPlayList() { }
        public MusicPlayList(string name)
        {
            Name = name;
            savePath = Application.StartupPath + @"\Data\Playlist(" + Name + @").playlist";
        }

        public void AddMusic(string path,string name)
        {
            if(path == null || name == null)
            {
                throw new ApplicationException("Arquivo vazio");
            }
            
            music = new Music(path, name);
            musicList.Add(music);
        }
        public void SaveMusics()
        {
            serializer.BinarySerialize(musicList, savePath);
        }
        public void LoadMusics()
        {
            List<Music> musics = (List<Music>)serializer.BinaryDeserialize(savePath);

            musicList = musics;
        }
        public void RemoveMusic(string name)
        {
            musicList.RemoveAll(x => x.Name == name);
        }
        public List<Music> GetList()
        {            
            
            return musicList.OrderBy(x => x.Name).ToList();
        }
        public string GetPath(string name)
        {            
            if(musicList.Find(x => x.Name == name).Arquivo == null)
            {
                throw new ApplicationException();
            }
            return musicList.Find(x => x.Name == name).Arquivo;
        }
    }

    [Serializable]
    class Music
    {
        public string Arquivo { get; protected set; }
        public string Name { get; protected set; }
        public Music() { }
        public Music(string path, string name)
        {
            Arquivo = path;
            Name = name;
        }
    }
}

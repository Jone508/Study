using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicMgr : BaseManager<MusicMgr> 
{
	private AudioSource bkMusic = null;

    //音效列表
    private List<AudioSource> soundList = new List<AudioSource>();

	public MusicMgr()
	{
		MonoMgr.GetInstance().AddUpdateListener(Update);
	}

	private void Update() {
		for (int i = soundList.Count - 1; i >= 0; --i)
		{
			if(!soundList[i].isPlaying)
			{
				GameObject.Destroy(soundList[i]);
				soundList.RemoveAt(i);
			}
		}
	}


}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;

namespace UnityEngine.UI.Extensions.Examples.FancyScrollViewExample09
{
	internal static class TextureLoader
	{
		private class Loader : MonoBehaviour
		{
			private readonly Dictionary<string, Texture> cache = new Dictionary<string, Texture>();

			private static Loader instance;

			public static Loader Instance
			{
				get
				{
					object obj = instance;
					if (obj == null)
					{
						obj = Object.FindFirstObjectByType<Loader>() ?? new GameObject(typeof(TextureLoader).Name).AddComponent<Loader>();
						instance = (Loader)obj;
					}
					return (Loader)obj;
				}
			}

			public void Load(string url, Action<(string Url, Texture Texture)> onSuccess)
			{
				if (cache.TryGetValue(url, out var value))
				{
					onSuccess((url, value));
					return;
				}
				StartCoroutine(DownloadTexture(url, delegate((string Url, Texture Texture) result)
				{
					cache[result.Url] = result.Texture;
					onSuccess(result);
				}));
			}

			private IEnumerator DownloadTexture(string url, Action<(string Url, Texture Texture)> onSuccess)
			{
				using UnityWebRequest request = UnityWebRequestTexture.GetTexture(url);
				yield return request.SendWebRequest();
				if (request.result == UnityWebRequest.Result.ConnectionError)
				{
					Debug.LogErrorFormat("Error: {0}", request.error);
					yield break;
				}
				onSuccess((url, ((DownloadHandlerTexture)request.downloadHandler).texture));
			}

			private void OnDestroy()
			{
				foreach (KeyValuePair<string, Texture> item in cache)
				{
					Object.Destroy(item.Value);
				}
				instance = null;
			}
		}

		public static void Load(string url, Action<(string Url, Texture Texture)> onSuccess)
		{
			Loader.Instance.Load(url, onSuccess);
		}
	}
}

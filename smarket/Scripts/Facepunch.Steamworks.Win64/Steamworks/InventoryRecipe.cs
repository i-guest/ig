using System;

namespace Steamworks
{
	public struct InventoryRecipe : IEquatable<InventoryRecipe>
	{
		public struct Ingredient
		{
			public int DefinitionId;

			public InventoryDef Definition;

			public int Count;

			internal static Ingredient FromString(string part)
			{
				return default(Ingredient);
			}
		}

		public InventoryDef Result;

		public Ingredient[] Ingredients;

		public string Source;

		internal static InventoryRecipe FromString(string part, InventoryDef Result)
		{
			return default(InventoryRecipe);
		}

		internal bool ContainsIngredient(InventoryDef inventoryDef)
		{
			return false;
		}

		public static bool operator ==(InventoryRecipe a, InventoryRecipe b)
		{
			return false;
		}

		public static bool operator !=(InventoryRecipe a, InventoryRecipe b)
		{
			return false;
		}

		public override bool Equals(object p)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public bool Equals(InventoryRecipe p)
		{
			return false;
		}
	}
}

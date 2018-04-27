class AddImageToTeam < ActiveRecord::Migration[5.2]
  def change
    add_column :teams, :image_uid, :string
  end
end

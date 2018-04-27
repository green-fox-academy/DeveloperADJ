class AddImagenameToTeam < ActiveRecord::Migration[5.2]
  def change
    add_column :teams, :image_name, :string
  end
end

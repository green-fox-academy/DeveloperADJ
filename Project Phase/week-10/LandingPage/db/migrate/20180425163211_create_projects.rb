class CreateProjects < ActiveRecord::Migration[5.2]
  def change
    create_table :projects do |t|
      t.string :thumbnail_url
      t.string :title
      t.string :description

      t.timestamps
    end
  end
end

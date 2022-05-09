<template>
  <li class="li-item">
    <a :class="{ 'collapsed-a': this.$parent.isCollapsed, active: linkItem.href == $route.path }" :href="linkItem.href">
      <span :class="linkItem.icon"></span>
      <div :class="{ collapse: this.$parent.isCollapsed }">
        <p>{{ linkItem.text }}</p>
      </div>
    </a>
  </li>
</template>

<script>
export default {
  name: "MenuItem",
  props: {
    linkItem: Object
  }
}
</script>

<style scoped>

  a {
    transition: background-color 300ms ease-in-out;
    @apply bg-transparent flex items-center gap-2.5 p-4 font-sans font-medium text-lg text-gray-600 rounded hover:bg-gray-200;
  }

  .active {
    @apply bg-gray-100 text-black;
  }


  .collapsed-a {
    @apply justify-center;
  }

  .collapse {
    display: none;
  }

</style>
